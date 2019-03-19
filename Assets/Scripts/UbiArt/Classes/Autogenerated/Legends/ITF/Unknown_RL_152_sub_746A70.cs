using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_152_sub_746A70 : CSerializable {
		[Serialize("cycleDisplayCountByMessage")] public uint cycleDisplayCountByMessage;
		[Serialize("cycleDelay"                )] public float cycleDelay;
		[Serialize("itemPath"                  )] public Path itemPath;
		[Serialize("itemPoolSize"              )] public uint itemPoolSize;
		[Serialize("itemSpace"                 )] public float itemSpace;
		[Serialize("itemSpeed"                 )] public float itemSpeed;
		[Serialize("iconeReferences"           )] public Placeholder iconeReferences;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(cycleDisplayCountByMessage));
			SerializeField(s, nameof(cycleDelay));
			SerializeField(s, nameof(itemPath));
			SerializeField(s, nameof(itemPoolSize));
			SerializeField(s, nameof(itemSpace));
			SerializeField(s, nameof(itemSpeed));
			SerializeField(s, nameof(iconeReferences));
		}
		public override uint? ClassCRC => 0x28166084;
	}
}

