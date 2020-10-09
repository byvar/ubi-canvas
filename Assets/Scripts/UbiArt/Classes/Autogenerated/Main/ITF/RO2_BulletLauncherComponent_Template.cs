using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_BulletLauncherComponent_Template : ActorComponent_Template {
		public Path bullet;
		public StringID launchBone;
		public float launchZOffset;
		public bool launchInRootScene;
		public StringID standAnim;
		public StringID standToOpenAnim;
		public StringID openAnim;
		public StringID fireAnim;
		public StringID openToStandAnim;
		public bool useTimedSpawnerData;
		public bool launchOnTrigger;
		public bool restoreBulletDepth;
		public float speedMultiplierFromDir;
		public bool replicateChildrenLinks;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bullet = s.SerializeObject<Path>(bullet, name: "bullet");
			launchBone = s.SerializeObject<StringID>(launchBone, name: "launchBone");
			launchZOffset = s.Serialize<float>(launchZOffset, name: "launchZOffset");
			launchInRootScene = s.Serialize<bool>(launchInRootScene, name: "launchInRootScene");
			standAnim = s.SerializeObject<StringID>(standAnim, name: "standAnim");
			standToOpenAnim = s.SerializeObject<StringID>(standToOpenAnim, name: "standToOpenAnim");
			openAnim = s.SerializeObject<StringID>(openAnim, name: "openAnim");
			fireAnim = s.SerializeObject<StringID>(fireAnim, name: "fireAnim");
			openToStandAnim = s.SerializeObject<StringID>(openToStandAnim, name: "openToStandAnim");
			useTimedSpawnerData = s.Serialize<bool>(useTimedSpawnerData, name: "useTimedSpawnerData");
			launchOnTrigger = s.Serialize<bool>(launchOnTrigger, name: "launchOnTrigger");
			restoreBulletDepth = s.Serialize<bool>(restoreBulletDepth, name: "restoreBulletDepth");
			speedMultiplierFromDir = s.Serialize<float>(speedMultiplierFromDir, name: "speedMultiplierFromDir");
			replicateChildrenLinks = s.Serialize<bool>(replicateChildrenLinks, name: "replicateChildrenLinks");
		}
		public override uint? ClassCRC => 0xCAB78F1E;
	}
}

