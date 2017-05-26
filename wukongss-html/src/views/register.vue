<template>
    <div>
        <hdmenu :backIcon='true' :backFun='backGo'></hdmenu>
        <div class="qr-code-box"></div>
        <div class="descript">微信扫一扫，关注悟空加速公众号，即可获取登录密码！O(∩_∩)O~~</div>
    </div>
</template>
<script>
    import hdmenu from '@/components/menu.vue';
    export default {
        name:'register',
        data (){
            return {

            }
        },
        components:{
            hdmenu
        },
        methods:{
            backGo(){
                this.$router.push('/login');
            }
        }
    }
</script>
<style>
    .qr-code-box{
        width: 300px;
        height: 300px;
        background-image: url(../imgs/e.jpg);
        background-size: 100%;
        margin: 0 auto;
        margin-top: 50px;
    }

    .descript{
        text-align: center;
        color:#fff;
        margin-top: 10px;
    }
</style>

