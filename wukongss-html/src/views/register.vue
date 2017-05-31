<template>
    <div class="content">
        <hdmenu :backIcon='true' :backFun='backGo'></hdmenu>
        <img src="../img/e.jpg" class="qr-code-box" />
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
<style lang="scss">
    .content{
        position: absolute;
        height: 100%;
        width: 100%;
        background-color: #f39943;

        .qr-code-box{
            width: 300px;
            height: 300px;
            margin: 0 auto;
            margin-top: 50px;
            display: block;
        }

        .descript{
            text-align: center;
            color:#fff;
            margin-top: 10px;
        }
    }
</style>

