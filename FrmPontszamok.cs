using System.Text;

namespace WFA251002;

public partial class FrmPontszamok : Form
{
    public List<Dolgozat> Dolgozatok { get; private set; } = [];
    public const string File = "..\\..\\..\\resources\\dolgozatok.txt";

    public FrmPontszamok()
    {
        InitializeComponent();
        this.Load += FrmPontszamokLoad;
        this.FormClosing += FrmPontszamokFormClosing;
        btnAdatbevitel.Click += BtnAdatbevitelClick;
        btnAtlag.Click += BtnAtlagClick;
        nudDiakPontszama.GotFocus += NudDiakPontszamaGotFocus;
    }

    private void NudDiakPontszamaGotFocus(object? sender, EventArgs e) =>
        nudDiakPontszama.Select(0, 1);

    private void BtnAtlagClick(object? sender, EventArgs e) =>
        lblAtlagPont.Text = $"{Dolgozatok.Average(d => d.Pontszam):0.00} pont";

    private void BtnAdatbevitelClick(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtDiakNeve.Text)) return;

        Dolgozatok.Add(new()
        {
            Nev = txtDiakNeve.Text,
            Pontszam = (int)nudDiakPontszama.Value
        });

        RtbDiakokAddRow(Dolgozatok[^1]);

        txtDiakNeve.Clear();
        nudDiakPontszama.Value = 0;
        lblAtlagPont.Text = string.Empty;
        txtDiakNeve.Focus();
    }

    private void FrmPontszamokFormClosing(object? sender, FormClosingEventArgs e)
    {
        using StreamWriter sw = new(File, false, Encoding.UTF8);
        foreach (var d in Dolgozatok) sw.WriteLine($"{d.Nev};{d.Pontszam}");
    }

    private void FrmPontszamokLoad(object? sender, EventArgs e)
    {
        using StreamReader sr = new(File, Encoding.UTF8);
        while (!sr.EndOfStream)
        {
            var v = sr.ReadLine()!.Split(';');
            Dolgozatok.Add(new() 
            { 
                Nev = v[0], 
                Pontszam = int.Parse(v[1])
            });
        }

        foreach (var d in Dolgozatok) RtbDiakokAddRow(d);
    }

    private void RtbDiakokAddRow(Dolgozat d) =>
        rtbDiakok.Text += $"{d.Nev+':',-25}{d.Pontszam,3} pont\n";
}
