using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class SequencePlayerComponent_Template : ActorComponent_Template {
		public CArray<Generic<SequenceEvent_Template>> events;
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
		public CList<SequenceTrackInfo_Template> trackList;
		public CList<Actor> instanceActors;
		public CArray<uint> instanceActorsCRC;
		public CMap<StringID, uint> friendlyToInstanceActor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				events = s.SerializeObject<CArray<Generic<SequenceEvent_Template>>>(events, name: "events");
				unskippableDurationFirstTime = s.Serialize<float>(unskippableDurationFirstTime, name: "unskippableDurationFirstTime");
				deactivatedPlayers = s.Serialize<bool>(deactivatedPlayers, name: "deactivatedPlayers");
				reactivateAlive = s.Serialize<bool>(reactivateAlive, name: "reactivateAlive");
				reactivatePlayers = s.Serialize<bool>(reactivatePlayers, name: "reactivatePlayers");
				saveInitialView = s.Serialize<bool>(saveInitialView, name: "saveInitialView");
				trackList = s.SerializeObject<CList<SequenceTrackInfo_Template>>(trackList, name: "trackList");
			} else if (Settings.s.game == Settings.Game.RL) {
				events = s.SerializeObject<CArray<Generic<SequenceEvent_Template>>>(events, name: "events");
				unskippableDurationFirstTime = s.Serialize<float>(unskippableDurationFirstTime, name: "unskippableDurationFirstTime");
				deactivatedPlayers = s.Serialize<bool>(deactivatedPlayers, name: "deactivatedPlayers");
				reactivateAlive = s.Serialize<bool>(reactivateAlive, name: "reactivateAlive");
				reactivatePlayers = s.Serialize<bool>(reactivatePlayers, name: "reactivatePlayers");
				startOnActivate = s.Serialize<bool>(startOnActivate, name: "startOnActivate");
				useLocalisationId = s.Serialize<bool>(useLocalisationId, name: "useLocalisationId");
				saveInitialView = s.Serialize<bool>(saveInitialView, name: "saveInitialView");
				fullAABB = s.SerializeObject<AABB>(fullAABB, name: "fullAABB");
				forceAlwaysActive = s.Serialize<bool>(forceAlwaysActive, name: "forceAlwaysActive");
				trackList = s.SerializeObject<CList<SequenceTrackInfo_Template>>(trackList, name: "trackList");
				instanceActors = s.SerializeObject<CList<Actor>>(instanceActors, name: "instanceActors");
				instanceActorsCRC = s.SerializeObject<CArray<uint>>(instanceActorsCRC, name: "instanceActorsCRC");
				friendlyToInstanceActor = s.SerializeObject<CMap<StringID, uint>>(friendlyToInstanceActor, name: "friendlyToInstanceActor");
			} else if (Settings.s.game == Settings.Game.COL) {
				events = s.SerializeObject<CArray<Generic<SequenceEvent_Template>>>(events, name: "events");
				unskippableDurationFirstTime = s.Serialize<float>(unskippableDurationFirstTime, name: "unskippableDurationFirstTime");
				deactivatedPlayers = s.Serialize<bool>(deactivatedPlayers, name: "deactivatedPlayers", options: CSerializerObject.Options.BoolAsByte);
				reactivateAlive = s.Serialize<bool>(reactivateAlive, name: "reactivateAlive", options: CSerializerObject.Options.BoolAsByte);
				reactivatePlayers = s.Serialize<bool>(reactivatePlayers, name: "reactivatePlayers", options: CSerializerObject.Options.BoolAsByte);
				startOnActivate = s.Serialize<bool>(startOnActivate, name: "startOnActivate", options: CSerializerObject.Options.BoolAsByte);
				useLocalisationId = s.Serialize<bool>(useLocalisationId, name: "useLocalisationId", options: CSerializerObject.Options.BoolAsByte);
				saveInitialView = s.Serialize<bool>(saveInitialView, name: "saveInitialView", options: CSerializerObject.Options.BoolAsByte);
				fullAABB = s.SerializeObject<AABB>(fullAABB, name: "fullAABB");
				forceAlwaysActive = s.Serialize<bool>(forceAlwaysActive, name: "forceAlwaysActive", options: CSerializerObject.Options.BoolAsByte);
				trackList = s.SerializeObject<CList<SequenceTrackInfo_Template>>(trackList, name: "trackList");
				instanceActors = s.SerializeObject<CList<Actor>>(instanceActors, name: "instanceActors");
				instanceActorsCRC = s.SerializeObject<CArray<uint>>(instanceActorsCRC, name: "instanceActorsCRC");
				friendlyToInstanceActor = s.SerializeObject<CMap<StringID, uint>>(friendlyToInstanceActor, name: "friendlyToInstanceActor");
			} else {
				events = s.SerializeObject<CArray<Generic<SequenceEvent_Template>>>(events, name: "events");
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
				trackList = s.SerializeObject<CList<SequenceTrackInfo_Template>>(trackList, name: "trackList");
				instanceActors = s.SerializeObject<CList<Actor>>(instanceActors, name: "instanceActors");
				instanceActorsCRC = s.SerializeObject<CArray<uint>>(instanceActorsCRC, name: "instanceActorsCRC");
				friendlyToInstanceActor = s.SerializeObject<CMap<StringID, uint>>(friendlyToInstanceActor, name: "friendlyToInstanceActor");
			}
		}
		public override uint? ClassCRC => 0x8B1C2D3C;
	}
}

