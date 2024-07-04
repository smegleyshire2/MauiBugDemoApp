using System.Collections.ObjectModel;

namespace BugDemoApp
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> Items = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();

            BindableLayout.SetItemsSource(slItems, Items);
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            Items.Add($"Item {Items.Count + 1}");
        }

        private void btnRemove_Clicked(object sender, EventArgs e)
        {
            if (Items.Count > 0)
                Items.RemoveAt(Items.Count - 1);
        }
    }
}
