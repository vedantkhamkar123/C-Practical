class overloading
{
  public int sum(int a,int b)
  {
    int x;
    return x=a+b;
  }
  public int sum(int a,int b,int c)
  {
    int y;
    return y=a+b+c;
  }
  public float sum(float a,float b)
  {
    float u;
    return u=a+b;
  }
  public float sum(float a,float b,float c)
  {
    float v;
    return v=a+b+c;
  }
}
public partial class_Default:System.Web.UI.Page
{
overloading o;
protected void Page_Load(object sender,EventArgs e)
{
o=new overloading();
}
protected void Button1_Click(object sender,EventArgs e)
{
Lable1.Text=Convert.ToString(o.sum(10,20));
Lable1.Text=Convert.ToString(o.sum(10,20,30));
Lable1.Text=Convert.ToString(o.sum(12.0f,23.1f,32.5f));
}
}
