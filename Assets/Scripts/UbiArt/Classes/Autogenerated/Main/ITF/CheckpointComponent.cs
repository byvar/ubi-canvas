using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class CheckpointComponent : ActorComponent {
		[Serialize("INDEX"                                                          )] public uint INDEX;
		[Serialize("joinAlive"                                                      )] public bool joinAlive;
		[Serialize("persistent"                                                     )] public bool persistent;
		[Serialize("persistentSaveOnce"                                             )] public bool persistentSaveOnce;
		[Serialize("active"                                                         )] public bool active;
		[Serialize("persistentDataSaved"                                            )] public bool persistentDataSaved;
		[Serialize("canBeTriggeredWhenInactive"                                     )] public bool canBeTriggeredWhenInactive;

		[Serialize("bool__0"                                                        )] public bool bool__0;
		[Serialize("Enum_VH_0__1"                                                   )] public Enum_VH_0 Enum_VH_0__1;
		[Serialize("bool__2"                                                        )] public bool bool__2;
		[Serialize("uint__3"                                                        )] public uint uint__3;
		[Serialize("bool__4"                                                        )] public bool bool__4;
		[Serialize("bool__5"                                                        )] public bool bool__5;
		[Serialize("bool__6"                                                        )] public bool bool__6;
		[Serialize("Enum_VH_0__7"                                                   )] public Enum_VH_0 Enum_VH_0__7;
		[Serialize("bool__8"                                                        )] public bool bool__8;
		[Serialize("bool__9"                                                        )] public bool bool__9;
		[Serialize("bool__10"                                                       )] public bool bool__10;
		[Serialize("bool__11"                                                       )] public bool bool__11;
		[Serialize("bool__12"                                                       )] public bool bool__12;
		[Serialize("W1W_EventMPCFlag__13"                                           )] public W1W_EventMPCFlag W1W_EventMPCFlag__13;
		[Serialize("Path__14"                                                       )] public Path Path__14;
		[Serialize("bool__15"                                                       )] public bool bool__15;
		[Serialize("Path__16"                                                       )] public Path Path__16;
		[Serialize("CArray<CheckpointComponent.SerializableDisguiseElementType>__17")] public CArray<CheckpointComponent.SerializableDisguiseElementType> CArray_CheckpointComponent_SerializableDisguiseElementType__17;
		[Serialize("Enum_VH_1__18"                                                  )] public Enum_VH_1 Enum_VH_1__18;
		[Serialize("Enum_VH_2__19"                                                  )] public Enum_VH_1 Enum_VH_1__19;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(INDEX));
					SerializeField(s, nameof(joinAlive));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(active));
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(INDEX));
					SerializeField(s, nameof(joinAlive));
					SerializeField(s, nameof(canBeTriggeredWhenInactive), boolAsByte: true);
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(active));
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(INDEX));
					SerializeField(s, nameof(Enum_VH_0__1));
					SerializeField(s, nameof(joinAlive));
				}
				SerializeField(s, nameof(persistent));
				SerializeField(s, nameof(persistentSaveOnce));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(active));
					SerializeField(s, nameof(persistentDataSaved));
				}
				SerializeField(s, nameof(Enum_VH_0__7));
				SerializeField(s, nameof(bool__8));
				SerializeField(s, nameof(bool__9));
				SerializeField(s, nameof(bool__10));
				SerializeField(s, nameof(bool__11));
				SerializeField(s, nameof(bool__12));
				SerializeField(s, nameof(W1W_EventMPCFlag__13));
				SerializeField(s, nameof(Path__14));
				SerializeField(s, nameof(bool__15));
				SerializeField(s, nameof(Path__16));
				SerializeField(s, nameof(CArray_CheckpointComponent_SerializableDisguiseElementType__17));
				SerializeField(s, nameof(Enum_VH_1__18));
				SerializeField(s, nameof(Enum_VH_1__19));
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(INDEX));
					SerializeField(s, nameof(joinAlive));
				}
				SerializeField(s, nameof(persistent));
				SerializeField(s, nameof(persistentSaveOnce));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(active));
					SerializeField(s, nameof(persistentDataSaved));
				}
			}
		}
		[Games(GameFlags.VH)]
		public partial class SerializableDisguiseElementType : CSerializable {
			[Serialize("Enum_VH_0__0")] public Enum_VH_0 Enum_VH_0__0;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(Enum_VH_0__0));
			}
			public enum Enum_VH_0 {
				[Serialize("Value_0"  )] Value_0 = 0,
				[Serialize("Value_1"  )] Value_1 = 1,
				[Serialize("Value_2"  )] Value_2 = 2,
				[Serialize("Value_4"  )] Value_4 = 4,
				[Serialize("Value_8"  )] Value_8 = 8,
				[Serialize("Value_12" )] Value_12 = 12,
				[Serialize("Value_14" )] Value_14 = 14,
				[Serialize("Value_16" )] Value_16 = 16,
				[Serialize("Value_32" )] Value_32 = 32,
				[Serialize("Value_33" )] Value_33 = 33,
				[Serialize("Value_64" )] Value_64 = 64,
				[Serialize("Value_128")] Value_128 = 128,
				[Serialize("Value__1" )] Value__1 = -1,
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_15")] Value_15 = 15,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
			[Serialize("Value_14")] Value_14 = 14,
			[Serialize("Value_16")] Value_16 = 16,
		}
		public enum Enum_VH_1 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x5534CAE2;
	}
}

