class MarkSheet
{
  private float m1,m2,m3;
  string name;
  public MarkSheet()
  {
    m1=20;
    m2=40;
    m3=40;
  }
  public MarkSheet(float ms)
  {
    m1-ms;
  }
  public MarkSheet(float ms1,float ms2,float ms3)
  {
    m1-ms1;
    m2=ms2;
    m3=ms3;
  }
  public float tot()
  {
    float t=m1+m2+m3;
    return t;
  }
}
public partial class_Default:System.Web.UI.Page
{
protected void Page_Load(object sender,EventArgs e)
{
}
protected void Button_Click(object sender,EventArgs e)
{
MarkSheet a=new MarkSheet();
MarkSheet b=new MarkSheet();
MarkSheet c=new MarkSheet();
MarkSheet d=new MarkSheet();
Response.Write("In Marksheet 1:");
Response.Write(a.tot()+"<br>");
Response.Write("In Marksheet 2:");
Response.Write(b.tot()+"<br>");
Response.Write("In Marksheet 3:");
Response.Write(c.tot()+"<br>");
Response.Write("In Marksheet 4:");
Response.Write(d.tot()+"<br>");
}
}
