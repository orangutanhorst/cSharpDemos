namespace Testability
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice >= 30f)
                return (float) (0.1 * order.TotalPrice);
            return 0;
        }
    }
}