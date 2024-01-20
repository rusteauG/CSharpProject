//Working with Nullable Values
bool? AreYouMajor = null;
if (AreYouMajor.HasValue) {
    if (AreYouMajor.Value == true)
    {

    }
    else if (!AreYouMajor.Value == false)
    {

    }
}
   else
   {
   Console.WriteLine("Neither");
   }

int? TicketOnSale = null;
int availableTicket;
if(TicketOnSale == null)
{
    availableTicket = 0;
}
else
{
    availableTicket = TicketOnSale.Value;
    //Or CAST  = (int)TicketOnSale;
}
Console.WriteLine("Available Tickets = {0}",availableTicket);
