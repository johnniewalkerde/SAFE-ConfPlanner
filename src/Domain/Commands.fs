module Commands

open Model

type Command =
  | ScheduleConference of Conference
  | AddOrganizerToConference of Organizer
  | RemoveOrganizerFromConference of Organizer
  | Vote of Voting
  | RevokeVoting of Voting
  | FinishVotingPeriod
  | ReopenVotingPeriod
  | ProposeAbstract of ConferenceAbstract
  | AcceptAbstract of ConferenceAbstract
  | RejectAbstract of ConferenceAbstract
