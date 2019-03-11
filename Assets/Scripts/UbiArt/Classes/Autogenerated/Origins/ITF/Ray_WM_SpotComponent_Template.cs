using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_WM_SpotComponent_Template : CSerializable {
		[Serialize("closedAnim"     )] public StringID closedAnim;
		[Serialize("newAnim"        )] public StringID newAnim;
		[Serialize("cannotEnterAnim")] public StringID cannotEnterAnim;
		[Serialize("openAnim"       )] public StringID openAnim;
		[Serialize("completedAnim"  )] public StringID completedAnim;
		[Serialize("textNameID"     )] public StringID textNameID;
		[Serialize("isMid"          )] public bool isMid;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(closedAnim));
			SerializeField(s, nameof(newAnim));
			SerializeField(s, nameof(cannotEnterAnim));
			SerializeField(s, nameof(openAnim));
			SerializeField(s, nameof(completedAnim));
			SerializeField(s, nameof(textNameID));
			SerializeField(s, nameof(isMid));
		}
		public override uint? ClassCRC => 0x2713EB21;
	}
}

