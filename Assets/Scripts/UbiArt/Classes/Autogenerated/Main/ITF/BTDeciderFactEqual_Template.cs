using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTDeciderFactEqual_Template : BTDecider_Template {
		[Serialize("fact"    )] public StringID fact;
		[Serialize("value"   )] public string value;
		[Serialize("type"    )] public EValueType type;
		[Serialize("type"    )] public EValueType_Legends typeLegends;
		[Serialize("superior")] public bool superior;
		[Serialize("inferior")] public bool inferior;
		[Serialize("superior")] public EValueType_Legends superiorLegends;
		[Serialize("inferior")] public EValueType_Legends inferiorLegends;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(fact));
				SerializeField(s, nameof(value));
				SerializeField(s, nameof(typeLegends));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(fact));
				SerializeField(s, nameof(value));
				SerializeField(s, nameof(typeLegends));
				SerializeField(s, nameof(superiorLegends));
				SerializeField(s, nameof(inferiorLegends));
			} else {
				SerializeField(s, nameof(fact));
				SerializeField(s, nameof(value));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(superior));
				SerializeField(s, nameof(inferior));
			}
		}
		public enum EValueType {
			[Serialize("EValueType_Unknown"   )] Unknown = 0,
			[Serialize("EValueType_Boolean"   )] Boolean = 1,
			[Serialize("EValueType_Integer32" )] Integer32 = 2,
			[Serialize("EValueType_UInteger32")] UInteger32 = 3,
			[Serialize("EValueType_Float"     )] Float = 4,
			[Serialize("EValueType_StringId"  )] StringId = 5,
			[Serialize("EValueType_Vec2"      )] Vec2 = 6,
			[Serialize("EValueType_Vec3"      )] Vec3 = 7,
			[Serialize("EValueType_ObjectRef" )] ObjectRef = 8,
			[Serialize("EValueType_Event"     )] Event = 9,
		}
		public enum EValueType_Legends {
			[Serialize("EValueType_Boolean"   )] Boolean = 1,
			[Serialize("EValueType_Integer32" )] Integer32 = 2,
			[Serialize("EValueType_UInteger32")] UInteger32 = 3,
			[Serialize("EValueType_Float"     )] Float = 4,
			[Serialize("EValueType_StringId"  )] StringId = 5,
			[Serialize("EValueType_Vec2"      )] Vec2 = 6,
			[Serialize("EValueType_Vec3"      )] Vec3 = 7,
			[Serialize("EValueType_ObjectRef" )] ObjectRef = 8,
			[Serialize("EValueType_Event"     )] Event = 9,
		}
		public override uint? ClassCRC => 0xE1129F90;
	}
}

