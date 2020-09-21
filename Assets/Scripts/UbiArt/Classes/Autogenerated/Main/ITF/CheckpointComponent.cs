using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class CheckpointComponent : ActorComponent {
		public uint INDEX;
		public bool joinAlive;
		public bool persistent;
		public bool persistentSaveOnce;
		public bool active;
		public bool persistentDataSaved;
		public bool canBeTriggeredWhenInactive;

		public bool bool__0;
		public Enum_VH_0 Enum_VH_0__1;
		public bool bool__2;
		public uint uint__3;
		public bool bool__4;
		public bool bool__5;
		public bool bool__6;
		public Enum_VH_0 Enum_VH_0__7;
		public bool bool__8;
		public bool bool__9;
		public bool bool__10;
		public bool bool__11;
		public bool bool__12;
		public W1W_EventMPCFlag W1W_EventMPCFlag__13;
		public Path Path__14;
		public bool bool__15;
		public Path Path__16;
		public CArrayO<CheckpointComponent.SerializableDisguiseElementType> CArray_CheckpointComponent_SerializableDisguiseElementType__17;
		public Enum_VH_1 Enum_VH_1__18;
		public Enum_VH_1 Enum_VH_1__19;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					INDEX = s.Serialize<uint>(INDEX, name: "INDEX");
					joinAlive = s.Serialize<bool>(joinAlive, name: "joinAlive");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					active = s.Serialize<bool>(active, name: "active");
				}
				if (Settings.s.isCatchThemAll) {
					uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
					uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
					uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
					uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
					uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
					uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
					uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
					uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
					uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					INDEX = s.Serialize<uint>(INDEX, name: "INDEX");
					joinAlive = s.Serialize<bool>(joinAlive, name: "joinAlive");
					canBeTriggeredWhenInactive = s.Serialize<bool>(canBeTriggeredWhenInactive, name: "canBeTriggeredWhenInactive", options: CSerializerObject.Options.BoolAsByte);
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					active = s.Serialize<bool>(active, name: "active");
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					INDEX = s.Serialize<uint>(INDEX, name: "INDEX");
					Enum_VH_0__1 = s.Serialize<Enum_VH_0>(Enum_VH_0__1, name: "Enum_VH_0__1");
					joinAlive = s.Serialize<bool>(joinAlive, name: "joinAlive");
				}
				persistent = s.Serialize<bool>(persistent, name: "persistent");
				persistentSaveOnce = s.Serialize<bool>(persistentSaveOnce, name: "persistentSaveOnce");
				if (s.HasFlags(SerializeFlags.Persistent)) {
					active = s.Serialize<bool>(active, name: "active");
					persistentDataSaved = s.Serialize<bool>(persistentDataSaved, name: "persistentDataSaved");
				}
				Enum_VH_0__7 = s.Serialize<Enum_VH_0>(Enum_VH_0__7, name: "Enum_VH_0__7");
				bool__8 = s.Serialize<bool>(bool__8, name: "bool__8");
				bool__9 = s.Serialize<bool>(bool__9, name: "bool__9");
				bool__10 = s.Serialize<bool>(bool__10, name: "bool__10");
				bool__11 = s.Serialize<bool>(bool__11, name: "bool__11");
				bool__12 = s.Serialize<bool>(bool__12, name: "bool__12");
				W1W_EventMPCFlag__13 = s.SerializeObject<W1W_EventMPCFlag>(W1W_EventMPCFlag__13, name: "W1W_EventMPCFlag__13");
				Path__14 = s.SerializeObject<Path>(Path__14, name: "Path__14");
				bool__15 = s.Serialize<bool>(bool__15, name: "bool__15");
				Path__16 = s.SerializeObject<Path>(Path__16, name: "Path__16");
				CArray_CheckpointComponent_SerializableDisguiseElementType__17 = s.SerializeObject<CArrayO<CheckpointComponent.SerializableDisguiseElementType>>(CArray_CheckpointComponent_SerializableDisguiseElementType__17, name: "CArray_CheckpointComponent_SerializableDisguiseElementType__17");
				Enum_VH_1__18 = s.Serialize<Enum_VH_1>(Enum_VH_1__18, name: "Enum_VH_1__18");
				Enum_VH_1__19 = s.Serialize<Enum_VH_1>(Enum_VH_1__19, name: "Enum_VH_1__19");
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					INDEX = s.Serialize<uint>(INDEX, name: "INDEX");
					joinAlive = s.Serialize<bool>(joinAlive, name: "joinAlive");
				}
				persistent = s.Serialize<bool>(persistent, name: "persistent");
				persistentSaveOnce = s.Serialize<bool>(persistentSaveOnce, name: "persistentSaveOnce");
				if (s.HasFlags(SerializeFlags.Persistent)) {
					active = s.Serialize<bool>(active, name: "active");
					persistentDataSaved = s.Serialize<bool>(persistentDataSaved, name: "persistentDataSaved");
				}
			}
		}
		[Games(GameFlags.VH)]
		public partial class SerializableDisguiseElementType : CSerializable {
			public Enum_VH_0 Enum_VH_0__0;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
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

