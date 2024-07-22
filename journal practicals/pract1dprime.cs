{
int n,i,c;
  n=int.Parse(TextBox1.Text);
  for(c=2;c<=n-1;c++)
  {
    if(n%c)==0)
      break;
  }
  if(n==1)
    Response.Write(n+"is neither prime nor composite");
  else if(c<n-1)
    Response.Write(n+"is not prime number");
  else
    Response.Write(n+"is prime number");
}
}
