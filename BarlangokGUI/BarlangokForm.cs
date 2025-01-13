using System.Text;

namespace BarlangokGUI;

public partial class BarlangokForm : Form
{
    private const string RESDIR = "C:\\PROJECTS\\CSHARP25011301\\RESOURCES";
    private List<Barlang> barlangok = [];
    private Barlang selBarlang = null; 

    public BarlangokForm()
    {
        InitializeComponent();
        this.Load += BarlangokFormLoad;
        btnKereses.Click += BtnKeresesClick;
        btnMentes.Click += BtnMentesClick;
    }

    private void BtnMentesClick(object? sender, EventArgs e)
    {
        try
        {
            selBarlang.Hossz = int.Parse(tbHossz.Text);
            selBarlang.Melyseg = int.Parse(tbMely.Text);
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
        finally { AlapAllapot(); }
    }

    private void BtnKeresesClick(object? sender, EventArgs e)
    {
        var res = barlangok
            .SingleOrDefault(b => b.Azon == int.Parse(tbAzon.Text));

        if (res is null)
        {
            _ = MessageBox.Show("Ezzel az azonosítóval nem létezik barlang!");
            AlapAllapot();
        }
        else
        {
            selBarlang = res;
            lblNev.Text = res.Nev;
            tbHossz.Text = $"{res.Hossz}";
            tbMely.Text = $"{res.Melyseg}";
            btnMentes.Enabled = true;
        }
    }

    private void BarlangokFormLoad(object? sender, EventArgs e)
    {
        using StreamReader sr = new($"{RESDIR}\\barlangok.txt", Encoding.UTF8);
        _ = sr.ReadLine();
        while (!sr.EndOfStream) barlangok.Add(new(sr.ReadLine()));
    }

    private void AlapAllapot()
    {
        tbAzon.Text = string.Empty;
        lblNev.Text = string.Empty;
        tbHossz.Text = string.Empty;
        tbMely.Text = string.Empty;
        btnMentes.Enabled = false;
        selBarlang = null;
    }
}
