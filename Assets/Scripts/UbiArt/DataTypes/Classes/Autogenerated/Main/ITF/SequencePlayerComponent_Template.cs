namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class SequencePlayerComponent_Template : ActorComponent_Template {
		public CArrayO<Generic<SequenceEvent_Template>> events;
		public float unskippableDurationFirstTime;
		public bool deactivatedPlayers;
		public bool reactivateAlive;
		public bool reactivatePlayers;
		public bool startOnActivate;
		public bool useLocalisationId;
		public bool isCinematic;
		public bool saveInitialView;
		public AABB fullAABB;
		public bool forceAlwaysActive;
		public bool forceNotSensibleToTimeFactor;
		public CListO<SequenceTrackInfo_Template> trackList;
		public CListO<Actor> instanceActors;
		public CArrayP<uint> instanceActorsCRC;
		public CMap<StringID, uint> friendlyToInstanceActor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				events = s.SerializeObject<CArrayO<Generic<SequenceEvent_Template>>>(events, name: "events");
				unskippableDurationFirstTime = s.Serialize<float>(unskippableDurationFirstTime, name: "unskippableDurationFirstTime");
				deactivatedPlayers = s.Serialize<bool>(deactivatedPlayers, name: "deactivatedPlayers");
				reactivateAlive = s.Serialize<bool>(reactivateAlive, name: "reactivateAlive");
				reactivatePlayers = s.Serialize<bool>(reactivatePlayers, name: "reactivatePlayers");
				saveInitialView = s.Serialize<bool>(saveInitialView, name: "saveInitialView");
				trackList = s.SerializeObject<CListO<SequenceTrackInfo_Template>>(trackList, name: "trackList");
			} else if (s.Settings.game == Settings.Game.RL) {
				events = s.SerializeObject<CArrayO<Generic<SequenceEvent_Template>>>(events, name: "events");
				unskippableDurationFirstTime = s.Serialize<float>(unskippableDurationFirstTime, name: "unskippableDurationFirstTime");
				deactivatedPlayers = s.Serialize<bool>(deactivatedPlayers, name: "deactivatedPlayers");
				reactivateAlive = s.Serialize<bool>(reactivateAlive, name: "reactivateAlive");
				reactivatePlayers = s.Serialize<bool>(reactivatePlayers, name: "reactivatePlayers");
				startOnActivate = s.Serialize<bool>(startOnActivate, name: "startOnActivate");
				useLocalisationId = s.Serialize<bool>(useLocalisationId, name: "useLocalisationId");
				saveInitialView = s.Serialize<bool>(saveInitialView, name: "saveInitialView");
				fullAABB = s.SerializeObject<AABB>(fullAABB, name: "fullAABB");
				forceAlwaysActive = s.Serialize<bool>(forceAlwaysActive, name: "forceAlwaysActive");
				trackList = s.SerializeObject<CListO<SequenceTrackInfo_Template>>(trackList, name: "trackList");
				instanceActors = s.SerializeObject<CListO<Actor>>(instanceActors, name: "instanceActors");
				instanceActorsCRC = s.SerializeObject<CArrayP<uint>>(instanceActorsCRC, name: "instanceActorsCRC");
				friendlyToInstanceActor = s.SerializeObject<CMap<StringID, uint>>(friendlyToInstanceActor, name: "friendlyToInstanceActor");
			} else if (s.Settings.game == Settings.Game.COL) {
				events = s.SerializeObject<CArrayO<Generic<SequenceEvent_Template>>>(events, name: "events");
				unskippableDurationFirstTime = s.Serialize<float>(unskippableDurationFirstTime, name: "unskippableDurationFirstTime");
				deactivatedPlayers = s.Serialize<bool>(deactivatedPlayers, name: "deactivatedPlayers", options: CSerializerObject.Options.BoolAsByte);
				reactivateAlive = s.Serialize<bool>(reactivateAlive, name: "reactivateAlive", options: CSerializerObject.Options.BoolAsByte);
				reactivatePlayers = s.Serialize<bool>(reactivatePlayers, name: "reactivatePlayers", options: CSerializerObject.Options.BoolAsByte);
				startOnActivate = s.Serialize<bool>(startOnActivate, name: "startOnActivate", options: CSerializerObject.Options.BoolAsByte);
				useLocalisationId = s.Serialize<bool>(useLocalisationId, name: "useLocalisationId", options: CSerializerObject.Options.BoolAsByte);
				saveInitialView = s.Serialize<bool>(saveInitialView, name: "saveInitialView", options: CSerializerObject.Options.BoolAsByte);
				fullAABB = s.SerializeObject<AABB>(fullAABB, name: "fullAABB");
				forceAlwaysActive = s.Serialize<bool>(forceAlwaysActive, name: "forceAlwaysActive", options: CSerializerObject.Options.BoolAsByte);
				trackList = s.SerializeObject<CListO<SequenceTrackInfo_Template>>(trackList, name: "trackList");
				instanceActors = s.SerializeObject<CListO<Actor>>(instanceActors, name: "instanceActors");
				instanceActorsCRC = s.SerializeObject<CArrayP<uint>>(instanceActorsCRC, name: "instanceActorsCRC");
				friendlyToInstanceActor = s.SerializeObject<CMap<StringID, uint>>(friendlyToInstanceActor, name: "friendlyToInstanceActor");
			} else {
				events = s.SerializeObject<CArrayO<Generic<SequenceEvent_Template>>>(events, name: "events");
				unskippableDurationFirstTime = s.Serialize<float>(unskippableDurationFirstTime, name: "unskippableDurationFirstTime");
				deactivatedPlayers = s.Serialize<bool>(deactivatedPlayers, name: "deactivatedPlayers");
				reactivateAlive = s.Serialize<bool>(reactivateAlive, name: "reactivateAlive");
				reactivatePlayers = s.Serialize<bool>(reactivatePlayers, name: "reactivatePlayers");
				startOnActivate = s.Serialize<bool>(startOnActivate, name: "startOnActivate");
				useLocalisationId = s.Serialize<bool>(useLocalisationId, name: "useLocalisationId");
				isCinematic = s.Serialize<bool>(isCinematic, name: "isCinematic");
				saveInitialView = s.Serialize<bool>(saveInitialView, name: "saveInitialView");
				fullAABB = s.SerializeObject<AABB>(fullAABB, name: "fullAABB");
				forceAlwaysActive = s.Serialize<bool>(forceAlwaysActive, name: "forceAlwaysActive");
				forceNotSensibleToTimeFactor = s.Serialize<bool>(forceNotSensibleToTimeFactor, name: "forceNotSensibleToTimeFactor");
				trackList = s.SerializeObject<CListO<SequenceTrackInfo_Template>>(trackList, name: "trackList");
				instanceActors = s.SerializeObject<CListO<Actor>>(instanceActors, name: "instanceActors");
				instanceActorsCRC = s.SerializeObject<CArrayP<uint>>(instanceActorsCRC, name: "instanceActorsCRC");
				friendlyToInstanceActor = s.SerializeObject<CMap<StringID, uint>>(friendlyToInstanceActor, name: "friendlyToInstanceActor");
			}
		}
		public override uint? ClassCRC => 0x8B1C2D3C;
	}
}

