namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class UpgradeAreaScRsp
	{
		[ProtoMember(8)] public int Level;
		[ProtoMember(3)] public int Retcode;
		[ProtoMember(15)] public int CFKCEODLJHK;
	}
	
}
