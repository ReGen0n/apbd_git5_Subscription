namespace LegacyRenewalApp
{
    public class SupportFeeCalculator
    {
        public decimal Calculate(bool includePremiumSupport, string normalizedPlanCode, ref string notes)
        {
            if (!includePremiumSupport)
            {
                return 0m;
            }

            decimal supportFee = 0m;

            if (normalizedPlanCode == "START")
            {
                supportFee = 200m;
            }
            else if (normalizedPlanCode == "PRO")
            {
                supportFee = 400m;
            }
            else if (normalizedPlanCode == "ENTERPRISE")
            {
                supportFee = 700m;
            }

            notes += "premium support included; ";
            return supportFee;
        }
    }
}