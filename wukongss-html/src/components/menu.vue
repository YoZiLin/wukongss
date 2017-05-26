<template>
    <div class="menu">
        <div class="menu-left">
            <a v-if='moreIcon' >☰</a>
            <mu-raised-button label="返回" v-if='backIcon' @click="backFun();" backgroundColor="#a4c639"/>
        </div>
        <div class="menu-right">
            <a>━</a>
            <a>✖</a>
        </div>
    </div>
</template>
<script>
    export default {
        data(){
            return {}
        },
        props:{
            moreIcon:false,
            backIcon:false,
            backFun:{type:Function}
        }
    }
</script>
<style lang="scss">
    .menu{
        position: absolute;
        color:#000;
        z-index: 100;
        width: 100%;
        display: flex;
        top:3px;

        .menu-left{
            text-align: left;
            padding-left: 10px;
        }

        .menu-right{
            text-align: right;

            a{
                margin-right: 20px;
                vertical-align: content;
            }
        }
    }

    .menu>div{
        flex: 1;

        a{
            cursor: pointer;
            color: #000;
            font-size: 20px;
        }
    }
</style>
