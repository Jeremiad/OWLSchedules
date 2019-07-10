using System;
using System.Collections.Generic;

namespace SchedulesCli.Models
{
    public partial class ScheduleModel
    {
        public OwlApiData Data { get; set; }
        public Meta Meta { get; set; }
    }

    public partial class OwlApiData
    {
        public long Id { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public long EndDateMs { get; set; }
        public long SeriesId { get; set; }
        public List<StageElement> Stages { get; set; }
    }

    public partial class StageElement
    {
        public long Id { get; set; }
        public string Slug { get; set; }
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public List<TournamentElement> Tournaments { get; set; }
        public List<StageMatch> Matches { get; set; }
        public List<Week> Weeks { get; set; }
    }

    public partial class StageMatch
    {
        public long Id { get; set; }
        public List<Winner> Competitors { get; set; }
        public List<Score> Scores { get; set; }
        public long ConclusionValue { get; set; }
        public string ConclusionStrategy { get; set; }
        public Winner Winner { get; set; }
        public object Home { get; set; }
        public string State { get; set; }
        public string Status { get; set; }
        public string StatusReason { get; set; }
        public MatchAttributes Attributes { get; set; }
        public List<GameElement> Games { get; set; }
        public List<object> ClientHints { get; set; }
        public PurpleBracket Bracket { get; set; }
        public long DateCreated { get; set; }
        public List<object> Flags { get; set; }
        public string Handle { get; set; }
        public List<string> CompetitorStatuses { get; set; }
        public string TimeZone { get; set; }
        public long? ActualStartDate { get; set; }
        public long? ActualEndDate { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public bool ShowStartTime { get; set; }
        public bool ShowEndTime { get; set; }
        public long StartDateTs { get; set; }
        public long EndDateTs { get; set; }
        public string YoutubeId { get; set; }
        public List<long> Wins { get; set; }
        public List<long> Ties { get; set; }
        public List<long> Losses { get; set; }
        public List<Video> Videos { get; set; }
        public MatchTournament Tournament { get; set; }
        public List<BroadcastChannel> BroadcastChannels { get; set; }
        public long? Round { get; set; }
        public long? Ordinal { get; set; }
        public long? WinnersNextMatch { get; set; }
        public long? WinnerRound { get; set; }
        public long? WinnerOrdinal { get; set; }
        public long? BestOf { get; set; }
        public string AttributesVersion { get; set; }
    }

    public partial class MatchAttributes
    {
        public string Tag { get; set; }
    }

    public partial class PurpleBracket
    {
        public long Id { get; set; }
        public long MatchConclusionValue { get; set; }
        public string MatchConclusionStrategy { get; set; }
        public long Winners { get; set; }
        public long TeamSize { get; set; }
        public long RepeatableMatchUps { get; set; }
        public PurpleStage Stage { get; set; }
        public string Type { get; set; }
        public List<object> ClientHints { get; set; }
        public string AdvantageComparing { get; set; }
        public bool ThirdPlaceMatch { get; set; }
        public bool AllowDraw { get; set; }
        public long? BestOf { get; set; }
        public long? CompetitorSize { get; set; }
    }

    public partial class PurpleStage
    {
        public long Id { get; set; }
        public List<string> AvailableLanguages { get; set; }
        public PurpleTournament Tournament { get; set; }
        public string? Title { get; set; }
        public string Detail { get; set; }
    }

    public partial class PurpleTournament
    {
        public long Id { get; set; }
        public List<string> AvailableLanguages { get; set; }
        public string Game { get; set; }
        public bool Featured { get; set; }
        public bool Draft { get; set; }
        public string Handle { get; set; }
        public string Title { get; set; }
        public SeriesClass Series { get; set; }
        public string Location { get; set; }
        public string Prize { get; set; }
        public string Detail { get; set; }
        public string Region { get; set; }
    }

    public partial class SeriesClass
    {
        public long Id { get; set; }
    }

    public partial class BroadcastChannel
    {
        public string Id { get; set; }
        public string Url { get; set; }
    }

    public partial class Winner
    {
        public long Id { get; set; }
        public List<string> AvailableLanguages { get; set; }
        public string Handle { get; set; }
        public string Name { get; set; }
        public string HomeLocation { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string Game { get; set; }
        public string AbbreviatedName { get; set; }
        public string AddressCountry { get; set; }
        public Uri Logo { get; set; }
        public Uri Icon { get; set; }
        public Uri SecondaryPhoto { get; set; }
        public string Type { get; set; }
    }

    public partial class GameElement
    {
        public long Id { get; set; }
        public long Number { get; set; }
        public List<long> Points { get; set; }
        public GameAttributes Attributes { get; set; }
        public string AttributesVersion { get; set; }
        public string State { get; set; }
        public string Status { get; set; }
        public string StatusReason { get; set; }
        public object Stats { get; set; }
        public string Handle { get; set; }
        public SeriesClass Match { get; set; }
    }

    public partial class GameAttributes
    {
        public long? Build { get; set; }
        public string InstanceId { get; set; }
        public string Map { get; set; }
        public string MapGuid { get; set; }
        public MapScore MapScore { get; set; }
    }

    public partial class MapScore
    {
        public long Team1 { get; set; }
        public long Team2 { get; set; }
    }

    public partial class Score
    {
        public long Value { get; set; }
    }

    public partial class MatchTournament
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Prize { get; set; }
    }

    public partial class Video
    {
        public long Name { get; set; }
        public string Description { get; set; }
        public string VodLink { get; set; }
        public string YoutubeId { get; set; }
        public string ThumbnailUrl { get; set; }
    }

    public partial class TournamentElement
    {
        public long Id { get; set; }
        public string Type { get; set; }
    }

    public partial class Week
    {
        public long Id { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
        public string Name { get; set; }
        public List<WeekMatch> Matches { get; set; }
        public List<Event> Events { get; set; }
    }

    public partial class Event
    {
        public string Type { get; set; }
        public EventData Data { get; set; }
    }

    public partial class EventData
    {
        public List<string> Titles { get; set; }
        public string LocationText { get; set; }
        public Uri LocationUrl { get; set; }
        public Uri DescriptionUrl { get; set; }
        public Uri ImageUrl { get; set; }
        public long HostTeamId { get; set; }
        public string HostTeamColorUsage { get; set; }
        public Partner Partner { get; set; }
    }

    public partial class Partner
    {
        public string Title { get; set; }
        public object Website { get; set; }
    }

    public partial class WeekMatch
    {
        public long Id { get; set; }
        public List<Winner> Competitors { get; set; }
        public List<Score> Scores { get; set; }
        public long ConclusionValue { get; set; }
        public string ConclusionStrategy { get; set; }
        public Winner Winner { get; set; }
        public object Home { get; set; }
        public string State { get; set; }
        public string Status { get; set; }
        public string StatusReason { get; set; }
        public MatchAttributes Attributes { get; set; }
        public List<GameElement> Games { get; set; }
        public List<object> ClientHints { get; set; }
        public FluffyBracket Bracket { get; set; }
        public long DateCreated { get; set; }
        public List<object> Flags { get; set; }
        public string Handle { get; set; }
        public List<string> CompetitorStatuses { get; set; }
        public string TimeZone { get; set; }
        public long? ActualStartDate { get; set; }
        public long? ActualEndDate { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public bool ShowStartTime { get; set; }
        public bool ShowEndTime { get; set; }
        public long StartDateTs { get; set; }
        public long EndDateTs { get; set; }
        public string YoutubeId { get; set; }
        public List<long> Wins { get; set; }
        public List<long> Ties { get; set; }
        public List<long> Losses { get; set; }
        public List<Video> Videos { get; set; }
        public MatchTournament Tournament { get; set; }
        public List<BroadcastChannel> BroadcastChannels { get; set; }
        public string AttributesVersion { get; set; }
        public long? Round { get; set; }
        public long? Ordinal { get; set; }
        public long? WinnersNextMatch { get; set; }
        public long? WinnerRound { get; set; }
        public long? WinnerOrdinal { get; set; }
        public long? BestOf { get; set; }
    }

    public partial class FluffyBracket
    {
        public long Id { get; set; }
        public long MatchConclusionValue { get; set; }
        public string MatchConclusionStrategy { get; set; }
        public long Winners { get; set; }
        public long TeamSize { get; set; }
        public long RepeatableMatchUps { get; set; }
        public FluffyStage Stage { get; set; }
        public string Type { get; set; }
        public List<object> ClientHints { get; set; }
        public string AdvantageComparing { get; set; }
        public bool ThirdPlaceMatch { get; set; }
        public bool AllowDraw { get; set; }
        public long? BestOf { get; set; }
        public long? CompetitorSize { get; set; }
    }

    public partial class FluffyStage
    {
        public long Id { get; set; }
        public List<string> AvailableLanguages { get; set; }
        public PurpleTournament Tournament { get; set; }
        public string Title { get; set; }
    }

    public partial class Meta
    {
        public Strings Strings { get; set; }
    }

    public partial class Strings
    {
        public string OwlScheduleTitle { get; set; }
        public string OwlScheduleDropdownTeams { get; set; }
        public string OwlScheduleStagePreseason { get; set; }
        public string OwlScheduleStageStage1 { get; set; }
        public string OwlScheduleStageStage2 { get; set; }
        public string OwlScheduleStageStage3 { get; set; }
        public string OwlScheduleStageStage4 { get; set; }
        public string OwlScheduleStagePlayoffs { get; set; }
        public string OwlScheduleStageFinals { get; set; }
        public string OwlScheduleStagePlayoffsAndFinals { get; set; }
        public string OwlScheduleStageAllStar { get; set; }
        public string OwlScheduleDisclaimer1 { get; set; }
        public string OwlScheduleDisclaimer2 { get; set; }
        public string OwlSchedulePlayoffsDescription1 { get; set; }
        public string OwlSchedulePlayoffsDescription2 { get; set; }
        public string OwlScheduleSpoilers { get; set; }
        public string OwlScheduleLive { get; set; }
        public string OwlScheduleMatchDetails { get; set; }
        public string OwlScheduleStageEnd { get; set; }
        public string OwlScheduleToday { get; set; }
        public string OwlSchedulePrevWeek { get; set; }
        public string OwlScheduleNextWeek { get; set; }
        public string OwlScheduleTitleMatch { get; set; }
        public string OwlSchedulePrizePool { get; set; }
        public string OwlScheduleWeek { get; set; }
        public string OwlPageGrandFinalsHeroResultsLine2 { get; set; }
        public string OwlScheduleSeason2019 { get; set; }
        public string OwlStandingsPlayoffFormatStageTitle { get; set; }
        public string OwlPageAllstars2019Title { get; set; }
    }
}
