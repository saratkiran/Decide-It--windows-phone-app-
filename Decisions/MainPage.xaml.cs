using System;
using System.Linq;
using System.Windows;

namespace Decisions
{
    public partial class MainPage
    {
        private readonly Random random = new Random();

        public MainPage()
        {
            InitializeComponent();

            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            Decisions.ItemsSource = DecisionType.GetDecisionTypes();
        }

        private void OnDecide(object sender, RoutedEventArgs e)
        {
            if(Decisions.SelectedItem == null)
                return;

            var decisionType = (DecisionType)Decisions.SelectedItem;

            var decision = decisionType.Choices.ElementAt(random.Next(decisionType.Choices.Count()));

            MessageBox.Show(decision, "The decision is", MessageBoxButton.OK);
        }
    }
}