protected void Button1_Click(object sender,EventArgs e)
{
  string ch;
  int count=0;
  ch=TextBox1.Text;
  for(int i=0;i<ch.Length;i++)
  {
    if((ch.Substring(i,l)=="a") || (ch.Substring(i,l)=="e") || (ch.Substring(i,l)=="o") || (ch.Substring(i,l)=="i") || (ch.Substring(i,l)=="u"))
    {
      count++;
    }
  }
  Response.Write("Given String:"+ch);
  Response.Write("Total Number of Vowels:"+count);
}
}
