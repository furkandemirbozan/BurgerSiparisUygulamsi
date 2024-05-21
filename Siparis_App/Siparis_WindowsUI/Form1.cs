using Siparis_Bussiness.Concrete;
using Siparis_Entities.Concrete;
using Siparis_WindowsUI.DTO;

namespace Siparis_WindowsUI
{
    public partial class Form1 : Form
    {
        CategoryManager categoryManager = new CategoryManager();
        ProductManager productManager = new ProductManager();
        List<CardItemDto> cardItemDtos = new List<CardItemDto>();
        OrderManager orderManager = new OrderManager();

        public Form1()
        {
           // cbxCategory ve cbxProduct ComboBox'lar�na kategorileri ve �r�nleri y�kler, bunlar�n g�r�nt�lenecek metinlerini ve de�erlerini s�ras�yla "Name" ve "Id" alanlar�na g�re ayarlar.
            InitializeComponent();
            cbxCategory.DataSource = categoryManager.GetAll();
            cbxCategory.DisplayMember = "Name";
            cbxCategory.ValueMember = "Id";

            cbxProduct.DataSource = productManager.GetAll();
            cbxProduct.DisplayMember = "Name";
            cbxProduct.ValueMember = "Id";
        }
        //show prododuct 
        private void btnProduct_Click(object sender, EventArgs e)
        {
            LoginForms_1 login_Forms1 = new LoginForms_1();
            login_Forms1.ShowDialog();

            //ProductForm productForm = new ProductForm();
            //productForm.ShowDialog();
        }
        private void btnWorker_Click(object sender, EventArgs e)
        {
            LoginForms2 login_Forms2 = new LoginForms2();
            login_Forms2.ShowDialog();

            //FormWorker formWorker = new FormWorker();
            //formWorker.ShowDialog();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Login_Forms login_Forms = new Login_Forms();
            login_Forms.ShowDialog();

            //Form2 f2 = new Form2();
            //f2.ShowDialog();
        }

        private void cbxCategory_MouseClick(object sender, MouseEventArgs e)
        {
            //yyeni ekledi�im kategori g�z�km�yor diye cbxCategory e her t�klad���mda yeniden veritaban�ndan �ekiyorum
            cbxCategory.DataSource = categoryManager.GetAll();
        }


        //cbxCategory her de�i�ti�inde �r�nlere filtreleme i�lemi yapmak
        private void cbxCategory_SelectedValueChanged(object sender, EventArgs e)
        {

            var selectedcategory = (Category)cbxCategory.SelectedItem;
            cbxProduct.DataSource = productManager.GetProductsByCategory(selectedcategory.Id);
        }

        private void btnAddToCard_Click(object sender, EventArgs e)
        {
            //sepete eklenecek se�ilen �r�n� ay�rd�m product a cast ettim
            var selectedProduct = (Product)cbxProduct.SelectedItem;
            var newCardItem = new CardItemDto()
            {
                Price = selectedProduct.Price.ToString(),
                ProductName = selectedProduct.Name,
                Quantity = Convert.ToInt32(tbxQuantity.Text),
                Ket�apOlsunMu = radioButton1.Checked,
                MayonezOlsunMu = radioButton2.Checked,
                ProductId = selectedProduct.Id
            };
            //sepet listesine yeni �r�n ekledim

            cardItemDtos.Add(newCardItem);

            //Sepete eklenen �r�n�n aray�zde g�z�kmesi i�in lstCardItems a ekledim
            var listViewItem = new ListViewItem(newCardItem.ProductName);

            listViewItem.SubItems.Add(newCardItem.Price.ToString());
            listViewItem.SubItems.Add(newCardItem.Quantity.ToString());
            listViewItem.SubItems.Add(newCardItem.Ket�apOlsunMu ? "Evet" : "Hay�r");
            listViewItem.SubItems.Add(newCardItem.MayonezOlsunMu ? "Evet" : "Hay�r");
            lstCardItems.Items.Add(listViewItem);

        }

        private void btnRemoveFromCard_Click(object sender, EventArgs e)
        {
            try
            {
                lstCardItems.SelectedItems[0].Remove();

            }
            catch (Exception)
            {
                MessageBox.Show("�r�n se�in hocam");
            }
        }
        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.CreateDate = DateTime.Now;
            order.OrderItems = new List<OrderItem>();

            //Sepetteki �r�nleri gezerek sipari�in alt�na �r�nleri ekler 
            foreach (var item in cardItemDtos)
            {
                var orderItem = new OrderItem()
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                };
                order.OrderItems.Add(orderItem);

            }
            // Sipari� bilgilerini DB ye ekledim
            orderManager.Add(order);




            //Sepetteki �r�nleri sildim 
            cardItemDtos = new List<CardItemDto>();
            foreach (ListViewItem listItem in lstCardItems.Items)
            {
                //listview i�indeki �r�nleri sildim
                lstCardItems.Items.Remove(listItem);
            }


        }

    }
}
