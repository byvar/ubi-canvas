using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BubbleDreamerAIComponent_Template : CSerializable {
		[Serialize("bubbleBone"   )] public StringID bubbleBone;
		[Serialize("bubblePath"   )] public Path bubblePath;
		[Serialize("userTime"     )] public float userTime;
		[Serialize("cageStandAnim")] public StringID cageStandAnim;
		[Serialize("cagePullAnim" )] public StringID cagePullAnim;
		[Serialize("freeStandAnim")] public StringID freeStandAnim;
		[Serialize("freePullAnim" )] public StringID freePullAnim;
		[Serialize("caged"        )] public bool caged;
		[Serialize("bubbleZoffset")] public float bubbleZoffset;
		[Serialize("dialogs"      )] public Placeholder dialogs;
		[Serialize("outrolines"   )] public Placeholder outrolines;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bubbleBone));
			SerializeField(s, nameof(bubblePath));
			SerializeField(s, nameof(userTime));
			SerializeField(s, nameof(cageStandAnim));
			SerializeField(s, nameof(cagePullAnim));
			SerializeField(s, nameof(freeStandAnim));
			SerializeField(s, nameof(freePullAnim));
			SerializeField(s, nameof(caged));
			SerializeField(s, nameof(bubbleZoffset));
			SerializeField(s, nameof(dialogs));
			SerializeField(s, nameof(outrolines));
		}
		public override uint? ClassCRC => 0x74679794;
	}
}

