namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PNKCIFOCNFG
	{
		[ProtoMember(9)] public int StageId;
		[ProtoMember(13)] public int Retcode;
	}

}
