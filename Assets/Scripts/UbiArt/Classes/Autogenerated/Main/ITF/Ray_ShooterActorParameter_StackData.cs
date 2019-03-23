using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ShooterActorParameter_StackData : CSerializable {
		[Serialize("projectilePath"       )] public Path projectilePath;
		[Serialize("numProjectiles"       )] public uint numProjectiles;
		[Serialize("max"                  )] public uint max;
		[Serialize("inStackSize"          )] public uint inStackSize;
		[Serialize("notStackable"         )] public int notStackable;
		[Serialize("notStackableKeepAlive")] public int notStackableKeepAlive;
		[Serialize("type"                 )] public StringID type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(projectilePath));
			SerializeField(s, nameof(numProjectiles));
			SerializeField(s, nameof(max));
			SerializeField(s, nameof(inStackSize));
			SerializeField(s, nameof(notStackable));
			SerializeField(s, nameof(notStackableKeepAlive));
			SerializeField(s, nameof(type));
		}
	}
}

