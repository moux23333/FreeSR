namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneCastSkillCsReq
	{
		[ProtoMember(3)] public int CGBLGAIDCAB;
		[ProtoMember(14)] public int CNEAAFPFBKL;
		[ProtoMember(2)] public int CPHCEKHFFFF;
		[ProtoMember(1)] public List<int> CIJKBNNCGAF;
		[ProtoMember(8)] public int SkillIndex;
		[ProtoMember(5)] public List<int> GGDPKECKALL;
		[ProtoMember(10)] public MotionInfo TargetMotion;
	}
	
}
