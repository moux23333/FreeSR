namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class NGPCBPGDPFC
	{
		[ProtoMember(1)] public int Retcode;
		[ProtoMember(4)] public List<CHNHKPPKDIN> Pinlbbpcbkn;
	}

}
