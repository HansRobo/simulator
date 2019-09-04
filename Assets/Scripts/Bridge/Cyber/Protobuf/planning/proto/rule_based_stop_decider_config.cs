// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: rule_based_stop_decider_config.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.planning
{

    [global::ProtoBuf.ProtoContract()]
    public partial class RuleBasedStopDeciderConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public RuleBasedStopDeciderConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(0.3)]
        public double max_adc_stop_speed
        {
            get { return __pbn__max_adc_stop_speed ?? 0.3; }
            set { __pbn__max_adc_stop_speed = value; }
        }
        public bool ShouldSerializemax_adc_stop_speed()
        {
            return __pbn__max_adc_stop_speed != null;
        }
        public void Resetmax_adc_stop_speed()
        {
            __pbn__max_adc_stop_speed = null;
        }
        private double? __pbn__max_adc_stop_speed;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0.5)]
        public double max_valid_stop_distance
        {
            get { return __pbn__max_valid_stop_distance ?? 0.5; }
            set { __pbn__max_valid_stop_distance = value; }
        }
        public bool ShouldSerializemax_valid_stop_distance()
        {
            return __pbn__max_valid_stop_distance != null;
        }
        public void Resetmax_valid_stop_distance()
        {
            __pbn__max_valid_stop_distance = null;
        }
        private double? __pbn__max_valid_stop_distance;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(5)]
        public double search_beam_length
        {
            get { return __pbn__search_beam_length ?? 5; }
            set { __pbn__search_beam_length = value; }
        }
        public bool ShouldSerializesearch_beam_length()
        {
            return __pbn__search_beam_length != null;
        }
        public void Resetsearch_beam_length()
        {
            __pbn__search_beam_length = null;
        }
        private double? __pbn__search_beam_length;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(0.08)]
        public double search_beam_radius_intensity
        {
            get { return __pbn__search_beam_radius_intensity ?? 0.08; }
            set { __pbn__search_beam_radius_intensity = value; }
        }
        public bool ShouldSerializesearch_beam_radius_intensity()
        {
            return __pbn__search_beam_radius_intensity != null;
        }
        public void Resetsearch_beam_radius_intensity()
        {
            __pbn__search_beam_radius_intensity = null;
        }
        private double? __pbn__search_beam_radius_intensity;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(3.14)]
        public double search_range
        {
            get { return __pbn__search_range ?? 3.14; }
            set { __pbn__search_range = value; }
        }
        public bool ShouldSerializesearch_range()
        {
            return __pbn__search_range != null;
        }
        public void Resetsearch_range()
        {
            __pbn__search_range = null;
        }
        private double? __pbn__search_range;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(1.57)]
        public double is_block_angle_threshold
        {
            get { return __pbn__is_block_angle_threshold ?? 1.57; }
            set { __pbn__is_block_angle_threshold = value; }
        }
        public bool ShouldSerializeis_block_angle_threshold()
        {
            return __pbn__is_block_angle_threshold != null;
        }
        public void Resetis_block_angle_threshold()
        {
            __pbn__is_block_angle_threshold = null;
        }
        private double? __pbn__is_block_angle_threshold;

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue(80)]
        public double approach_distance_for_lane_change
        {
            get { return __pbn__approach_distance_for_lane_change ?? 80; }
            set { __pbn__approach_distance_for_lane_change = value; }
        }
        public bool ShouldSerializeapproach_distance_for_lane_change()
        {
            return __pbn__approach_distance_for_lane_change != null;
        }
        public void Resetapproach_distance_for_lane_change()
        {
            __pbn__approach_distance_for_lane_change = null;
        }
        private double? __pbn__approach_distance_for_lane_change;

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue(50)]
        public double urgent_distance_for_lane_change
        {
            get { return __pbn__urgent_distance_for_lane_change ?? 50; }
            set { __pbn__urgent_distance_for_lane_change = value; }
        }
        public bool ShouldSerializeurgent_distance_for_lane_change()
        {
            return __pbn__urgent_distance_for_lane_change != null;
        }
        public void Reseturgent_distance_for_lane_change()
        {
            __pbn__urgent_distance_for_lane_change = null;
        }
        private double? __pbn__urgent_distance_for_lane_change;

    }

}

#pragma warning restore 0612, 1591, 3021