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



    private async void linky_SelectedIndexChanged(object sender, EventArgs e)
    {
        {
            if (linky.SelectedValue != null)
            { 
                string vybraneId = zastavky.SelectedValue.ToString();

                using HttpClient client = new HttpClient();
                string json = await client.GetStringAsync("https://mhd.adamhojer.cz/departures?line="+zastavky+"&stop="+stops);

                JsonNode odjezdy = JsonNode.Parse(json);

                var data = odjezdy.AsArray().Select(u => new
                {
                    Linka = u["linka"].ToString(),
                    Směr = u["smer"].ToString(),
                    Odjezd = DateTime.Parse(u["cas_odjezdu"].ToString()).ToShortTimeString()
                }).ToList();

                dataGridOdjezdy.DataSource = data;
                


            }
        }
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
         
    }
}