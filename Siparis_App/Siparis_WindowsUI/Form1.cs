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
           // cbxCategory ve cbxProduct ComboBox'larýna kategorileri ve ürünleri yükler, bunlarýn görüntülenecek metinlerini ve deðerlerini sýrasýyla "Name" ve "Id" alanlarýna göre ayarlar.
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
            //yyeni eklediðim kategori gözükmüyor diye cbxCategory e her týkladýðýmda yeniden veritabanýndan çekiyorum
            cbxCategory.DataSource = categoryManager.GetAll();
        }


        //cbxCategory her deðiþtiðinde ürünlere filtreleme iþlemi yapmak
        private void cbxCategory_SelectedValueChanged(object sender, EventArgs e)
        {

            var selectedcategory = (Category)cbxCategory.SelectedItem;
            cbxProduct.DataSource = productManager.GetProductsByCategory(selectedcategory.Id);
        }

        private void btnAddToCard_Click(object sender, EventArgs e)
        {
            //sepete eklenecek seçilen ürünü ayýrdým product a cast ettim
            var selectedProduct = (Product)cbxProduct.SelectedItem;
            var newCardItem = new CardItemDto()
            {
                Price = selectedProduct.Price.ToString(),
                ProductName = selectedProduct.Name,
                Quantity = Convert.ToInt32(tbxQuantity.Text),
                KetçapOlsunMu = radioButton1.Checked,
                MayonezOlsunMu = radioButton2.Checked,
                ProductId = selectedProduct.Id
            };
            //sepet listesine yeni ürün ekledim

            cardItemDtos.Add(newCardItem);

            //Sepete eklenen ürünün arayüzde gözükmesi için lstCardItems a ekledim
            var listViewItem = new ListViewItem(newCardItem.ProductName);

            listViewItem.SubItems.Add(newCardItem.Price.ToString());
            listViewItem.SubItems.Add(newCardItem.Quantity.ToString());
            listViewItem.SubItems.Add(newCardItem.KetçapOlsunMu ? "Evet" : "Hayýr");
            listViewItem.SubItems.Add(newCardItem.MayonezOlsunMu ? "Evet" : "Hayýr");
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
                MessageBox.Show("Ürün seçin hocam");
            }
        }
        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.CreateDate = DateTime.Now;
            order.OrderItems = new List<OrderItem>();

            //Sepetteki ürünleri gezerek sipariþin altýna ürünleri ekler 
            foreach (var item in cardItemDtos)
            {
                var orderItem = new OrderItem()
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                };
                order.OrderItems.Add(orderItem);

            }
            // Sipariþ bilgilerini DB ye ekledim
            orderManager.Add(order);




            //Sepetteki ürünleri sildim 
            cardItemDtos = new List<CardItemDto>();
            foreach (ListViewItem listItem in lstCardItems.Items)
            {
                //listview içindeki ürünleri sildim
                lstCardItems.Items.Remove(listItem);
            }


        }

    }
}
