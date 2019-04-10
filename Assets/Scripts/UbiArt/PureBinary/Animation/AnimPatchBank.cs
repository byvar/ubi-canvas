using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimPatchBank::serialize
	// pbk.ckd file
	public class AnimPatchBank : CSerializable {
		[Serialize("version"  )] public uint version;
		[Serialize("link"     )] public Link link;
		[Serialize("unk"      )] public float unk;
		[Serialize("keys"     )] public KeyArray<int> keys;
		[Serialize("templates")] public CList<AnimTemplate> templates;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(version));
			SerializeField(s, nameof(link));
			SerializeField(s, nameof(unk));
			SerializeField(s, nameof(keys));
			SerializeField(s, nameof(templates));
		}

	}
}
