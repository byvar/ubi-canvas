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
		public uint version;
		public Link bankId;
		public float unk;
		public KeyArray<int> templateKeys;
		public CListO<AnimTemplate> templates;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			version = s.Serialize<uint>(version, name: "version");
			bankId = s.SerializeObject<Link>(bankId, name: "bankId");
			unk = s.Serialize<float>(unk, name: "unk");
			templateKeys = s.SerializeObject<KeyArray<int>>(templateKeys, name: "templateKeys");
			templates = s.SerializeObject<CListO<AnimTemplate>>(templates, name: "templates");
		}

	}
}
