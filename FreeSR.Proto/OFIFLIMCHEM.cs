namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class OFIFLIMCHEM
	{
		[ProtoMember(7)] public int OCCMKKLCFEI;
		[ProtoMember(1)] public bool IsFinish;
	}
	
}
