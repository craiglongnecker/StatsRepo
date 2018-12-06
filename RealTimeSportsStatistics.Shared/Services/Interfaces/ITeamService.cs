using RealTimeSportsStatistics.Shared.ViewModels;

namespace RealTimeSportsStatistics.Shared.Services.Interfaces
{
    public interface ITeamService
    {
        string IsTeamCityDenver(TeamViewModel team);
        string IsTeamNameBroncos(TeamViewModel team);
        string IsBroncosPrimaryColorBlue(TeamViewModel team);
        string IsBroncosSecondaryColorOrange(TeamViewModel team);
    }
}
