namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LHPCMAHLODM
	{
		[ProtoMember(2)] public int Progress;
		[ProtoMember(9)] public int HMMDPLAEHDE;
	}
	
}
