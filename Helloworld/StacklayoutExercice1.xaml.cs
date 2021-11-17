using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Helloworld
    {
        public partial class StacklayoutExercice1 : ContentPage
        {
            static int clic = 0;// ******************* ME 
            private int _index = 0;
            private string[] _quotes = new string[]
            {
            "Life is like riding a bicycle. To keep your balance, you must keep moving.",
            "You can't blame gravity for falling in love.",
            "Look deep into nature, and then you will understand everything better."
            };
            public StacklayoutExercice1()
            {
                InitializeComponent();
                currentQuote.Text = _quotes[_index];

            }
            void Handle_Clicked(object sender, System.EventArgs e)
            {
                _index++;
                if (_index >= _quotes.Length)
                    _index = 0;

                currentQuote.Text = _quotes[_index];
            }
            //********************* ME *********************************
            void next_Clicked(object sender, System.EventArgs e)
            {
                if (clic == 0)
                {
                    text.Text = "Text de seconde position";
                };
                if (clic == 1)
                {
                    text.Text = "Text de troisième position";
                }
                if (clic == 2)
                {
                    text.Text = "Text on vas boucler apres cela";
                    clic = 0;
                }
                else
                {
                    clic++;
                }
            }

        }
    }