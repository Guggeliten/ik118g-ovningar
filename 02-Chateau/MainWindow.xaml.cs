using System.Windows;

namespace Chateau_lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    ///
    /// Uppgift: räkna hur många viner i arrayen som har ett namn
    /// som innehåller "chateau". Skriv din kod i OnCountClick.
    ///
    /// Facit finns i FACIT.md.
    /// </summary>
    public partial class MainWindow : Window
    {
        // Listan (arrayen) med vinnamn. Rätt svar är 3.
        private string[] _viner =
        {
            "Chateau Margaux",
            "Barolo Riserva",
            "Chateau Latour",
            "Rioja Gran Reserva",
            "Chateau Mouton Rothschild",
            "Amarone della Valpolicella"
        };

        public MainWindow()
        {
            InitializeComponent();

            // Exempel på en loop: här går vi igenom arrayen och
            // visar varje vin i listan. En liknande loop behöver du
            // själv skriva nere i OnCountClick.
            foreach (string vin in _viner)
            {
                lstViner.Items.Add(vin);
            }
        }

        private void OnCountClick(object sender, RoutedEventArgs e)
        {
            int antalChateau = 0;

            // TIPS (pseudokod):
            //   Vi behöver nog gå igenom (loopa) alla viner i _viner – en i taget.
            //   För varje vin: kontrollera om namnet innehåller "chateau".
            //     - Det finns en färdig metod på en sträng som letar efter text i den.
            //     - Tänk på stora/små bokstäver – det finns en metod som gör om
            //       en text till små bokstäver innan du jämför.
            //   Om namnet innehåller "chateau": öka antalChateau med 1.
            //
            // TODO: skriv din loop här.

            txtResult.Text = "Antal Château-viner: " + antalChateau;
        }
    }
}
