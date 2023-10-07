namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ILLAHLPFMOD
	{
		[ProtoMember(4)] public int Adpempoleln;
		[ProtoMember(5)] public int Retcode;
		[ProtoMember(11)] public List<Mission> Fgpoclagodl;
	}

}
