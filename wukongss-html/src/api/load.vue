<template>
    <div id='load-box' v-show="visible">
        <mu-circular-progress :size="90" color="red"/>
    </div>
</template>
<script>
    export default {
        data() {
            return{
                visible:false,
                timer:null
            }
        }
    }
</script>
<style lang="scss">
    #load-box{
        position: absolute;
        width: 100%;
        height: 100%;
        background-color: #000;
        opacity: 0.5;
        z-index: 9999;
        text-align: center;

        .mu-circular-progress{
            top: 50%;
            margin-top: -90px;
        }
    }
</style>
