using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class SequencePlayerComponent_Template : ActorComponent_Template {
		[Serialize("events"                                    )] public CArray<Generic<SequenceEvent_Template>> events;
		[Serialize("unskippableDurationFirstTime"              )] public float unskippableDurationFirstTime;
		[Serialize("deactivatedPlayers"                        )] public bool deactivatedPlayers;
		[Serialize("reactivateAlive"                           )] public bool reactivateAlive;
		[Serialize("reactivatePlayers"                         )] public bool reactivatePlayers;
		[Serialize("startOnActivate"                           )] public bool startOnActivate;
		[Serialize("useLocalisationId"                         )] public bool useLocalisationId;
		[Serialize("isCinematic"                               )] public bool isCinematic;
		[Serialize("saveInitialView"                           )] public bool saveInitialView;
		[Serialize("fullAABB"                                  )] public AABB fullAABB;
		[Serialize("forceAlwaysActive"                         )] public bool forceAlwaysActive;
		[Serialize("forceNotSensibleToTimeFactor"              )] public bool forceNotSensibleToTimeFactor;
		[Serialize("trackList"                                 )] public CList<SequenceTrackInfo_Template> trackList;
		[Serialize("instanceActors"                            )] public CList<Actor> instanceActors;
		[Serialize("instanceActorsCRC"                         )] public CArray<uint> instanceActorsCRC;
		[Serialize("friendlyToInstanceActor"                   )] public CMap<StringID, uint> friendlyToInstanceActor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(events));
				SerializeField(s, nameof(unskippableDurationFirstTime));
				SerializeField(s, nameof(deactivatedPlayers));
				SerializeField(s, nameof(reactivateAlive));
				SerializeField(s, nameof(reactivatePlayers));
				SerializeField(s, nameof(saveInitialView));
				SerializeField(s, nameof(trackList));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(events));
				SerializeField(s, nameof(unskippableDurationFirstTime));
				SerializeField(s, nameof(deactivatedPlayers));
				SerializeField(s, nameof(reactivateAlive));
				SerializeField(s, nameof(reactivatePlayers));
				SerializeField(s, nameof(startOnActivate));
				SerializeField(s, nameof(useLocalisationId));
				SerializeField(s, nameof(saveInitialView));
				SerializeField(s, nameof(fullAABB));
				SerializeField(s, nameof(forceAlwaysActive));
				SerializeField(s, nameof(trackList));
				SerializeField(s, nameof(instanceActors));
				SerializeField(s, nameof(instanceActorsCRC));
				SerializeField(s, nameof(friendlyToInstanceActor));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(events));
				SerializeField(s, nameof(unskippableDurationFirstTime));
				SerializeField(s, nameof(deactivatedPlayers), boolAsByte: true);
				SerializeField(s, nameof(reactivateAlive), boolAsByte: true);
				SerializeField(s, nameof(reactivatePlayers), boolAsByte: true);
				SerializeField(s, nameof(startOnActivate), boolAsByte: true);
				SerializeField(s, nameof(useLocalisationId), boolAsByte: true);
				SerializeField(s, nameof(saveInitialView), boolAsByte: true);
				SerializeField(s, nameof(fullAABB));
				SerializeField(s, nameof(forceAlwaysActive), boolAsByte: true);
				SerializeField(s, nameof(trackList));
				SerializeField(s, nameof(instanceActors));
				SerializeField(s, nameof(instanceActorsCRC));
				SerializeField(s, nameof(friendlyToInstanceActor));
			} else {
				SerializeField(s, nameof(events));
				SerializeField(s, nameof(unskippableDurationFirstTime));
				SerializeField(s, nameof(deactivatedPlayers));
				SerializeField(s, nameof(reactivateAlive));
				SerializeField(s, nameof(reactivatePlayers));
				SerializeField(s, nameof(startOnActivate));
				SerializeField(s, nameof(useLocalisationId));
				SerializeField(s, nameof(isCinematic));
				SerializeField(s, nameof(saveInitialView));
				SerializeField(s, nameof(fullAABB));
				SerializeField(s, nameof(forceAlwaysActive));
				SerializeField(s, nameof(forceNotSensibleToTimeFactor));
				SerializeField(s, nameof(trackList));
				SerializeField(s, nameof(instanceActors));
				SerializeField(s, nameof(instanceActorsCRC));
				SerializeField(s, nameof(friendlyToInstanceActor));
			}
		}
		public override uint? ClassCRC => 0x8B1C2D3C;
	}
}

