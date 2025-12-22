/// <summary>
/// AdmissionEligibility - Checks admission eligibility based on subject scores
/// Criteria: Math ≥ 65, Physics ≥ 55, Chemistry ≥ 50 AND (Total ≥ 180 OR Math+Physics ≥ 140)
/// </summary>
class AdmissionEligibility
{
    /// <summary>
    /// Checks admission eligibility based on subject scores and total criteria
    /// Criteria: Math ≥ 65, Physics ≥ 55, Chemistry ≥ 50 AND (Total ≥ 180 OR Math+Physics ≥ 140)
    /// </summary>
    /// <param name="math">Mathematics score</param>
    /// <param name="phys">Physics score</param>
    /// <param name="chem">Chemistry score</param>
    /// <returns>Eligibility status</returns>
    public string CheckAdmissionEligibility(double math, double phys, double chem)
    {
        // Calculate totals for eligibility criteria
        double total = math + phys + chem;      // Total of all three subjects
        double mathphys = math + phys;          // Combined Math and Physics score

        // Check all eligibility conditions
        if (math >= 65 && phys >= 55 && chem >= 50 && (total >= 180 || mathphys >= 140))
        {
            return "eligible";
        }
        else
        {
            return "not eligible";
        }
    }
}