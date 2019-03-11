using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BulletLauncherComponent_Template : ActorComponent_Template {
		[Serialize("bullet"                )] public Path bullet;
		[Serialize("launchBone"            )] public StringID launchBone;
		[Serialize("launchZOffset"         )] public float launchZOffset;
		[Serialize("launchInRootScene"     )] public bool launchInRootScene;
		[Serialize("standAnim"             )] public StringID standAnim;
		[Serialize("standToOpenAnim"       )] public StringID standToOpenAnim;
		[Serialize("openAnim"              )] public StringID openAnim;
		[Serialize("fireAnim"              )] public StringID fireAnim;
		[Serialize("openToStandAnim"       )] public StringID openToStandAnim;
		[Serialize("useTimedSpawnerData"   )] public bool useTimedSpawnerData;
		[Serialize("launchOnTrigger"       )] public bool launchOnTrigger;
		[Serialize("restoreBulletDepth"    )] public bool restoreBulletDepth;
		[Serialize("speedMultiplierFromDir")] public float speedMultiplierFromDir;
		[Serialize("replicateChildrenLinks")] public bool replicateChildrenLinks;
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
			SerializeField(s, nameof(useTimedSpawnerData));
			SerializeField(s, nameof(launchOnTrigger));
			SerializeField(s, nameof(restoreBulletDepth));
			SerializeField(s, nameof(speedMultiplierFromDir));
			SerializeField(s, nameof(replicateChildrenLinks));
		}
		public override uint? ClassCRC => 0xCAB78F1E;
	}
}

