namespace LibraryApi.Helpers;

public class LateFeeCalculator
{
    private const decimal BaseLateFeePerDay = 0.50m;
    private const decimal AdditionalFeeAfter7Days = 1.00m;
    private const decimal AdditionalFeeAfter30Days = 2.00m;
    private const decimal MaxLateFee = 50.00m;
    
    public decimal CalculateLateFee(int daysOverdue)
    {
        if (daysOverdue <= 0)
            return 0;
        
        decimal fee = 0;
        
        // First 7 days: $0.50 per day
        if (daysOverdue <= 7)
        {
            fee = daysOverdue * BaseLateFeePerDay;
        }
        // Days 8-30: $1.00 per day
        else if (daysOverdue <= 30)
        {
            fee = (7 * BaseLateFeePerDay) + ((daysOverdue - 7) * AdditionalFeeAfter7Days);
        }
        // After 30 days: $2.00 per day
        else
        {
            fee = (7 * BaseLateFeePerDay) + 
                  (23 * AdditionalFeeAfter7Days) + 
                  ((daysOverdue - 30) * AdditionalFeeAfter30Days);
        }
        
        // Cap at maximum fee
        return Math.Min(fee, MaxLateFee);
    }
}
