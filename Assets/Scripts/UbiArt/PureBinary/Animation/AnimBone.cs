using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimBone::serialize
	public class AnimBone : CSerializable {
		[Serialize("key"       )] public Link key;
		[Serialize("tag"       )] public StringID tag;
		[Serialize("flags"     )] public byte flags;
		[Serialize("pointLinks")] public CList<Link> pointLinks; // links to AnimPatchPoint?
		[Serialize("parentKey" )] public Link parentKey;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(key));
			SerializeField(s, nameof(tag));
			SerializeField(s, nameof(flags));
			SerializeField(s, nameof(pointLinks));
			SerializeField(s, nameof(parentKey));
		}
		/*
		Example:
		108075A0 0A22DD9C 03 00000000 00000000
		108075D0 BC787C92 07 00000000 108075A0
		10807600 DA17A9B5 07 00000000 108075A0
		10807630 66E8124F 07 00000000 108075A0
		10807660 FA6BABDA 07 00000000 108075A0
		10807690 5D711B23 07 00000000 108075A0
		108076C0 7F7DD3B5 07 00000000 108076F0
		108076F0 A1219A1C 07 00000000 108075A0
		10807720 C5B82F5F 07 00000000 10807630
		10807750 80B53F55 07 00000000 108075A0
		10807780 0117AC92 07 00000000 108076C0
		108077B0 71315DD5 07 00000000 108076C0
		108077E0 BFDC7CCA 07 00000000 108075A0

		Adv:
		00000002 1569EC2C 03 00000004 00000003 00000004 00000005 00000006 00000000
		*/
	}
}
