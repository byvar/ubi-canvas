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
		[Serialize("deactivatedPlayers"                        )] public int deactivatedPlayers;
		[Serialize("reactivateAlive"                           )] public int reactivateAlive;
		[Serialize("reactivatePlayers"                         )] public int reactivatePlayers;
		[Serialize("saveInitialView"                           )] public int saveInitialView;
		[Serialize("CArray<Generic<SequenceEvent_Template>>__0")] public CArray<Generic<SequenceEvent_Template>> CArray_Generic_SequenceEvent_Template__0;
		[Serialize("float__1"                                  )] public float float__1;
		[Serialize("bool__2"                                   )] public bool bool__2;
		[Serialize("bool__3"                                   )] public bool bool__3;
		[Serialize("bool__4"                                   )] public bool bool__4;
		[Serialize("bool__5"                                   )] public bool bool__5;
		[Serialize("bool__6"                                   )] public bool bool__6;
		[Serialize("bool__7"                                   )] public bool bool__7;
		[Serialize("bool__8"                                   )] public bool bool__8;
		[Serialize("AABB__9"                                   )] public AABB AABB__9;
		[Serialize("bool__10"                                  )] public bool bool__10;
		[Serialize("bool__11"                                  )] public bool bool__11;
		[Serialize("CArray<SequenceTrackInfo_Template>__12"    )] public CArray<SequenceTrackInfo_Template> CArray_SequenceTrackInfo_Template__12;
		[Serialize("CArray<Actor>__13"                         )] public CArray<Actor> CArray_Actor__13;
		[Serialize("CArray<uint>__14"                          )] public CArray<uint> CArray_uint__14;
		[Serialize("CArray<StringID>__15"                      )] public CArray<StringID> CArray_StringID__15;
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
				SerializeField(s, nameof(unskippableDurationFirstTime));
				SerializeField(s, nameof(deactivatedPlayers), boolAsByte: true);
				SerializeField(s, nameof(reactivateAlive), boolAsByte: true);
				SerializeField(s, nameof(reactivatePlayers), boolAsByte: true);
				SerializeField(s, nameof(startOnActivate), boolAsByte: true);
				SerializeField(s, nameof(useLocalisationId), boolAsByte: true);
				SerializeField(s, nameof(saveInitialView), boolAsByte: true);
				SerializeField(s, nameof(fullAABB));
				SerializeField(s, nameof(forceAlwaysActive), boolAsByte: true);
				SerializeField(s, nameof(instanceActorsCRC));
				SerializeField(s, nameof(friendlyToInstanceActor));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(CArray_Generic_SequenceEvent_Template__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(bool__2));
				SerializeField(s, nameof(bool__3));
				SerializeField(s, nameof(bool__4));
				SerializeField(s, nameof(bool__5));
				SerializeField(s, nameof(bool__6));
				SerializeField(s, nameof(bool__7));
				SerializeField(s, nameof(bool__8));
				SerializeField(s, nameof(AABB__9));
				SerializeField(s, nameof(bool__10));
				SerializeField(s, nameof(bool__11));
				SerializeField(s, nameof(CArray_SequenceTrackInfo_Template__12));
				SerializeField(s, nameof(CArray_Actor__13));
				SerializeField(s, nameof(CArray_uint__14));
				SerializeField(s, nameof(CArray_StringID__15));
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
				SerializeField(s, nameof(instanceActorsCRC));
				SerializeField(s, nameof(friendlyToInstanceActor));
			}
		}
		public override uint? ClassCRC => 0x8B1C2D3C;
	}
}

