using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class PlayerLevelInfos : CSerializable {
		[Serialize("actorPath"      )] public Path actorPath;
		[Serialize("actorPath3D"    )] public Path actorPath3D;
		[Serialize("lumsReward"     )] public uint lumsReward;
		[Serialize("name"           )] public SmartLocId name;
		[Serialize("nameInBloomberg")] public SmartLocId nameInBloomberg;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actorPath));
			SerializeField(s, nameof(actorPath3D));
			SerializeField(s, nameof(lumsReward));
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(nameInBloomberg));
		}
	}
}

