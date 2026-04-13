namespace LegacyRenewalApp
{
    public class PaymentFeeCalculator
    {
        public decimal Calculate(decimal subtotal, string normalizedPaymentMethod)
        {
            if (normalizedPaymentMethod == "CARD")
            {
                return subtotal * 0.02m;
            }

            if (normalizedPaymentMethod == "PAYPAL")
            {
                return subtotal * 0.03m;
            }

            if (normalizedPaymentMethod == "BANK_TRANSFER")
            {
                return 0m;
            }

            throw new System.ArgumentException("Unsupported payment method");
        }
    }
}