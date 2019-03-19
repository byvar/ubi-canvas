using UnityEngine;

namespace UbiArt.ITF {
	public partial class MusicPartSet_Template : CSerializable {
		[Serialize("parts")] public CList<MusicPart_Template> parts;
	}
}