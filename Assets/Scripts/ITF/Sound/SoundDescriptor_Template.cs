using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class SoundDescriptor_Template : BaseObject {
		public SoundDescriptor_Template(Reader reader) : base(reader) {
			Debug.LogError("Decipher SoundDescriptor_Template @ " + reader.BaseStream.Position);
		}
	}
}
