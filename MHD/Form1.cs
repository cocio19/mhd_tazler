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

        JsonNode lines = JsonNode.Parse(json);

        foreach (var stop in lines.AsArray())
        {
            zastavky.Items.Add(stop);
        }

        string jsonb = await client.GetStringAsync("https://mhd.adamhojer.cz/stops");

        JsonNode stops = JsonNode.Parse(jsonb);

        var data = stops.AsArray().Select(u => new
        {
            Id = u["unique_id"].ToString(),
            Nazev = u["stop_name"].ToString()
        }).ToList();

        linky.DataSource = data;
    }



    private void linky_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}