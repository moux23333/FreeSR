namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetMultipleDropInfoScRsp
	{
		[ProtoMember(1)] public int Retcode;
		[ProtoMember(7)] public List<BKJMGLNHKLL> PHCLPCJKACJ;
	}
	
}
