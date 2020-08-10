using BookShop.BLL;
using BookShop.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Schema;

namespace BookShop.WebUI.aminPortal
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.PbId.DataTextField = "Name";
                this.PbId.DataValueField = "Id";
                //绑定图书分类数据
                this.PbId.DataSource = CategoryManager.GetAllCategoryList();
                this.PbId.DataBind();
                this.PbId.Items.Insert(0, new ListItem("===请选择图书分类===", ""));



                //绑定出版社数据
                this.PublisherName.DataTextField = "Name";
                this.PublisherName.DataValueField = "Id";
                this.PublisherName.DataSource = PublisherManager.GetPublishers();
                this.PublisherName.DataBind();
                this.PublisherName.Items.Insert(0, new ListItem("===请选择出版社===", ""));
            }
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            //图书图片是否上传
            bool fileOK = false;
            //定义上传图书图片路径
            string BookPath = Server.MapPath("~/Images/");
            //实例化图书/出版社实体类
            BookInfo book = new BookInfo();
            PublisherInfo Publishers = new PublisherInfo();

            //是否已经上传图书（HasFile  布尔类型 获取一个布尔值，用于表示FileUpload控件是否已经包含一个文件）
            if (FileUpload1.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                string[] AllowedExtensions = { ".gif", ".png", ".bmp", ".jpg" };
                for (int i = 0; i < AllowedExtensions.Length; i++)
                {
                    if (fileExtension == AllowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }
            if (fileOK)
            {
                try
                {
                    FileUpload1.SaveAs(BookPath + FileUpload1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("图片上传不成功！");
                }
            }
            else
            {
                MessageBox.Show("只能够上传图片文件！");
            }

            book.Title = txtTitle.Text;
            book.Author = txtAuthor.Text;
            book.Category = PbId.Text;
            book.Publisher = PublisherName.Text;
            book.ISBN = TxtISBN.Text;
            book.PublishDate = DateTime.Parse(TxtTime.Text);
            book.UnitPrice = Convert.ToInt32(TxtUnitPrice.Text);
            book.WordsCount = Convert.ToInt32(TxtWordsCount.Text);
            book.ContentDescription = TxtContentDescription.Text;
            book.ImgUrl = BookPath.ToString();

            BookManager.AddBook(book);


        }

        protected void PbId_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void PublisherName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}