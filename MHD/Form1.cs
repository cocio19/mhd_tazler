using System.Text.Json.Nodes;

namespace MHD;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        HttpClient client = new HttpClient();
        string json = await client.GetStringAsync("https://mhd.adamhojer.cz/lines");

        JsonNode stops = JsonNode.Parse(json);

        foreach (var stop in stops.AsArray())
        {
            zastavky.Items.Add(stop);
        }
        
    }

    private void linky_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}