using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BulletLauncherComponent_Template : CSerializable {
		[Serialize("bullet"             )] public Path bullet;
		[Serialize("launchBone"         )] public StringID launchBone;
		[Serialize("launchZOffset"      )] public float launchZOffset;
		[Serialize("launchInRootScene"  )] public bool launchInRootScene;
		[Serialize("standAnim"          )] public StringID standAnim;
		[Serialize("standToOpenAnim"    )] public StringID standToOpenAnim;
		[Serialize("openAnim"           )] public StringID openAnim;
		[Serialize("fireAnim"           )] public StringID fireAnim;
		[Serialize("openToStandAnim"    )] public StringID openToStandAnim;
		[Serialize("useSeparateFire"    )] public bool useSeparateFire;
		[Serialize("useTimedSpawnerData")] public bool useTimedSpawnerData;
		[Serialize("launchOnTrigger"    )] public bool launchOnTrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bullet));
			SerializeField(s, nameof(launchBone));
			SerializeField(s, nameof(launchZOffset));
			SerializeField(s, nameof(launchInRootScene));
			SerializeField(s, nameof(standAnim));
			SerializeField(s, nameof(standToOpenAnim));
			SerializeField(s, nameof(openAnim));
			SerializeField(s, nameof(fireAnim));
			SerializeField(s, nameof(openToStandAnim));
			SerializeField(s, nameof(useSeparateFire));
			SerializeField(s, nameof(useTimedSpawnerData));
			SerializeField(s, nameof(launchOnTrigger));
		}
		public override uint? ClassCRC => 0xE172D1F8;
	}
}

