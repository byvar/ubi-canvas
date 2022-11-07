namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BubbleDreamerAIComponent_Template : CSerializable {
		public StringID bubbleBone;
		public Path bubblePath;
		public float userTime;
		public StringID cageStandAnim;
		public StringID cagePullAnim;
		public StringID freeStandAnim;
		public StringID freePullAnim;
		public int caged;
		public float bubbleZoffset;
		public Placeholder dialogs;
		public Placeholder outrolines;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bubbleBone = s.SerializeObject<StringID>(bubbleBone, name: "bubbleBone");
			bubblePath = s.SerializeObject<Path>(bubblePath, name: "bubblePath");
			userTime = s.Serialize<float>(userTime, name: "userTime");
			cageStandAnim = s.SerializeObject<StringID>(cageStandAnim, name: "cageStandAnim");
			cagePullAnim = s.SerializeObject<StringID>(cagePullAnim, name: "cagePullAnim");
			freeStandAnim = s.SerializeObject<StringID>(freeStandAnim, name: "freeStandAnim");
			freePullAnim = s.SerializeObject<StringID>(freePullAnim, name: "freePullAnim");
			caged = s.Serialize<int>(caged, name: "caged");
			bubbleZoffset = s.Serialize<float>(bubbleZoffset, name: "bubbleZoffset");
			dialogs = s.SerializeObject<Placeholder>(dialogs, name: "dialogs");
			outrolines = s.SerializeObject<Placeholder>(outrolines, name: "outrolines");
		}
		public override uint? ClassCRC => 0x74679794;
	}
}

