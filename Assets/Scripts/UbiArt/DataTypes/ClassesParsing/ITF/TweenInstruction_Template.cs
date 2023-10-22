using System;

namespace UbiArt.ITF {
	public partial class TweenInstruction_Template : CSerializable {
		public virtual TweenInstruction Instantiate(Context context) {
			var tplType = GetType();
			var typeName = tplType.FullName;
			if (typeName.Contains("_Template"))
				typeName = typeName.Replace("_Template", "");

			Type type = Type.GetType(typeName);

			// Check whether the class exists
			if (type == null) throw new Exception($"Could not create instance class of component {tplType.FullName}");

			var c = (TweenInstruction)Activator.CreateInstance(type);
			c.InitContext(context);
			return c;
		}
	}
}